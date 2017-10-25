package com.Sugaring;

public class Tests {
	public static HomePage homePage() {
		return new HomePage();
	}
	
	public static LoginPage loginPage() {
		return new LoginPage();
	}
	public static void close() {
		Browser.closeBrowser();
	}
}
