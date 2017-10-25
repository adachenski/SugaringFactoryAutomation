package com.Sugaring;

public class LoginPage {
	public static String username = "Nas";
	public void goTo() {
		Browser.goToLogin();
	}
	
	public void login(String email, String password) {
		Browser.loginUser(email, password);
	}
	
	public boolean hasUser() {
		return Browser.verifyUser().equals(username);
	}
}
