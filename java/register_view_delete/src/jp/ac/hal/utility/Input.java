package jp.ac.hal.utility;

import java.io.BufferedReader;
import java.io.InputStreamReader;

public class Input {

	public String input() {
		BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
		String input="";
		try {
			input = reader.readLine();
		} catch (Exception e) {
			e.printStackTrace();
		}
		return input;
	}
	public int inputValue() {
		int value = 0;
		BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
		try {
			String input = reader.readLine();
			value = Integer.parseInt(input);
		} catch (NumberFormatException e) {
			 System.out.println("不正な数値です");
		}catch(Exception e){
			e.printStackTrace();
		}
		return value;
	}
}
