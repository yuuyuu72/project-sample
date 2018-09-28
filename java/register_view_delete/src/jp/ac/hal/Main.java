package jp.ac.hal;

import java.util.ArrayList;

import jp.ac.hal.utility.Input;
import jp.ac.hal.utility.Dao.ProductDao;
import jp.ac.hal.utility.Dao.UserDao;
import jp.ac.hal.utility.Entity.Product;
import jp.ac.hal.utility.Entity.User;

public class Main {
	User user;
	UserDao userDao;

	public static void main(String[] args) {
		System.out.println("start");
		Input input = new Input();
		UserDao userDao = new UserDao();
		ProductDao proDao = new ProductDao();

		while(true) {
			System.out.print("メニューを入力してください：");
			String inputMenu = input.input();
			User user = new User();
			Product product = new Product();

			if(inputMenu.equals("e")) {
				break;
			}

			switch(inputMenu) {
				case "au":
					System.out.println("[ユーザ登録]");
					System.out.print("メールアドレスを入力してください：");
					user.setMail(input.input());
					System.out.print("名前を入力してください：");
					user.setName(input.input());
					userDao.CreateUser(user);
					break;

				case "vu":
					ArrayList<User> list = new ArrayList<>();
					System.out.println("[ユーザ一覧]");
					System.out.println("id,mail,name");
					list.addAll(userDao.searchUser());
					for(int i=0;i<list.size();i++){
						User u = list.get(i);
						System.out.println(u.getId()+","+u.getMail()+","+u.getName());
					}
					break;

				case "ru":
					System.out.println("[ユーザ削除]");
					System.out.print("削除対象のIDを入力してください：");
					userDao.removeUser(input.inputValue());
					break;


				case "ap":
					System.out.println("[商品登録]");
					System.out.print("商品名を入力してください：");
					product.setName(input.input());

					//要検討
					while(true) {
						System.out.print("値段を入力してください：");
						int value = input.inputValue();
						if(value !=0) {
							product.setPrice(value);
							break;
						}
					}

					System.out.print("imgを入力してください：");
					product.setImg(input.input());
					proDao.CreateProducts(product);
					break;

				case "vp":
					ArrayList<Product> proList = new ArrayList<>();
					System.out.println("[商品一覧]");
					System.out.println("id,productName,price,img");
					proList.addAll(proDao.searchProduct());
					for(int i=0;i<proList.size();i++){
						Product p = proList.get(i);
						System.out.println(p.getId()+","+p.getname()+","+p.getPrice()+","+p.getImg());
					}
					break;

				case "rp":
					System.out.println("[商品削除]");
					System.out.print("削除対象のIDを入力してください：");
					proDao.removeProduct(input.inputValue());
					break;
			}
		}
		System.out.println("end");
	}
}
