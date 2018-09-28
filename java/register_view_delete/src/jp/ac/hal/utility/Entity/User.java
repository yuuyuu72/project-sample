package jp.ac.hal.utility.Entity;

public class User {
	private int id=0;
	private String mail;
	private String name;

	public int getId() {
		return id;
	}
	public String getMail() {
		return mail;
	}
	public String getName() {
		return name;
	}
	public void setId(int id) {
		this.id = id;
	}
	public void setMail(String mail) {
		this.mail = mail;
	}
	public void setName(String name) {
		this.name = name;
	}
}
