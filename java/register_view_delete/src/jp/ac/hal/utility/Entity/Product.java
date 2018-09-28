package jp.ac.hal.utility.Entity;

public class Product {
	private int id;
	private String name;
	private int price;
	private String img;

	public int getId() {
		return id;
	}

	public String getname() {
		return name;
	}

	public int getPrice() {
		return price;
	}

	public String getImg() {
		return img;
	}

	public void setId(int id) {
		this.id = id;
	}

	public void setName(String name) {
		this.name = name;
	}

	public void setPrice(int price) {
		this.price = price;
	}

	public void setImg(String img) {
		this.img = img;
	}
}
