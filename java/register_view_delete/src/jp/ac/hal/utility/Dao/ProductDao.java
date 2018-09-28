package jp.ac.hal.utility.Dao;

import java.util.ArrayList;

import jp.ac.hal.utility.Entity.Product;

public class ProductDao extends DatabaseAc {
	public void CreateProducts(Product product) {
		String sql = "insert into kadai04_products values(?,?,?,?);";
		DBConnection();
		try {
			pstat = conn.prepareStatement(sql);
			pstat.setString(1, null);
			pstat.setString(2, product.getname());
			pstat.setInt(3, product.getPrice());
			pstat.setString(4, product.getImg());
			pstat.executeUpdate();
			System.out.println("登録しました");
		} catch (Exception e) {
			//e.printStackTrace();
			System.out.println("登録できませんでした");
		} finally {
			DBClose();
		}
	}

	public ArrayList<Product> searchProduct() {
		ArrayList<Product> productList = new ArrayList<Product>();
		String sql = "select * from kadai04_products";
		DBConnection();
		try {
			pstat = conn.prepareStatement(sql);
			ret = pstat.executeQuery();
			if(!ret.next()) {
				System.out.println("データが存在しません");
			}
			while (ret.next()) {
				Product product = new Product();
				// スナップ情報
				product.setId(ret.getInt("id"));
				product.setName(ret.getString("name"));
				product.setPrice(ret.getInt("price"));
				product.setImg(ret.getString("img"));
				productList.add(product);
			}
		} catch (Exception e) {
			//e.printStackTrace();
			System.out.println("エラーです");
		} finally {
			DBClose();
		}
		return productList;
	}

	public int removeProduct(int id) {
		int errcode = 0;
		String sql = "delete from kadai04_products where id=?";
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
			System.out.println("そのIDは存在しません");
		} finally {
			DBClose();
		}
		return errcode;
	}
}
