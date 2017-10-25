package com.Sugaring;

public class HomePage {
	public static String url = "https://test.sugaringfactory.com/";
	public static String title = "[TEST] Sugaring Hair Removal | Sugaring Factory™ for professionals and home use.";
	public void goTo() {
		Browser.getUrl(url);
	}
	public boolean isAt() {
		return Browser.title().equals(title);
	}
	public void selectFirstItem() {
		Browser.getFirstItem();
	}
}
