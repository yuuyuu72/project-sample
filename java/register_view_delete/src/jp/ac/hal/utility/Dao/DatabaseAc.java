package jp.ac.hal.utility.Dao;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;

class DatabaseAc {
	Connection conn;
	private Statement state;
	ResultSet ret;
	PreparedStatement pstat;

	private static final String url = "jdbc:mysql:///jv34?user=root&useUnicode=true&characterEncoding=utf8";

	DatabaseAc(){
		this.conn = null;
		this.state = null;
		this.pstat = null;
		this.ret = null;
	}
	void DBConnection(){
		try {
			Class.forName("com.mysql.jdbc.Driver");
			conn = DriverManager.getConnection(url);
		}catch (Exception e) {
			e.printStackTrace();
		}
	}
	void DBClose(){
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