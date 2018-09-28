package jp.ac.hal.utility.Dao;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;

public class DatabaseAc {
	protected Connection conn;
	protected Statement state;
	protected ResultSet ret;
	protected PreparedStatement pstat;

	public static final String url = "jdbc:mysql:///jv34?user=root&useUnicode=true&characterEncoding=utf8";

	public DatabaseAc(){
		this.conn = null;
		this.state = null;
		this.pstat = null;
		this.ret = null;
	}
	protected void DBConnection(){
		try {
			Class.forName("com.mysql.jdbc.Driver");
			conn = DriverManager.getConnection(url);
		}catch (Exception e) {
			e.printStackTrace();
		}
	}
	protected void DBClose(){
		try{
			if(ret != null){
				ret.close();
			}
			if(pstat != null){
				pstat.close();
			}
			if(state != null){
				state.close();
			}
			if(conn != null){
				conn.close();
			}
		}catch(Exception e){
			e.printStackTrace();
		}
	}
}