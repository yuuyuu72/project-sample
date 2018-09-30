package jp.ac.hal.utility.Dao;

import java.util.ArrayList;

import jp.ac.hal.utility.Entity.User;

public class UserDao extends DatabaseAc {
	public void CreateUser(User user) {
		String sql = "insert into kadai04_users values(?,?,?);";
		DBConnection();
		try {
			pstat = conn.prepareStatement(sql);
			pstat.setString(1,null);
			pstat.setString(2, user.getMail());
			pstat.setString(3, user.getName());
			pstat.executeUpdate();
			System.out.println("登録完了");
		} catch (Exception e) {
			//e.printStackTrace();
			 System.out.println("既に登録されてるメールアドレスです");
		}finally {
			DBClose();
		}
	}

	public ArrayList<User> searchUser() {
		ArrayList<User> userList = new ArrayList<>();
		String sql = "select * from kadai04_users";
		DBConnection();
		try {
			pstat = conn.prepareStatement(sql);
			ret = pstat.executeQuery();
			if(!ret.next()) {
				System.out.println("データが存在しません");
			}
			while (ret.next()) {
				User user = new User();
				// スナップ情報
				user.setId(ret.getInt("id"));
				user.setMail(ret.getString("mail"));
				user.setName(ret.getString("name"));
				userList.add(user);
			}
		} catch (Exception e) {
			//e.printStackTrace();
			 System.out.println("取得エラーです");
		} finally {
			DBClose();
		}
		return userList;
	}

	public void removeUser(int id) {
		String sql = "delete from kadai04_users where id=?";
		DBConnection();
		try {
			pstat = conn.prepareStatement(sql);
			pstat.setInt(1,id);
			if(pstat.executeUpdate()!=0) {
				System.out.println("削除しました");
			}else {
				System.out.println("そのIDは存在しません");
			}
		} catch (Exception e) {
			//e.printStackTrace();
			 System.out.println("エラーです");
		} finally {
			DBClose();
		}
	}
}