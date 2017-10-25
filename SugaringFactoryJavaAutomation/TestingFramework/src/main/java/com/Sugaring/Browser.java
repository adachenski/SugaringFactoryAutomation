package com.Sugaring;

import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.chrome.ChromeDriver;

public class Browser {

	static WebDriver driver = new ChromeDriver();
	public static void getUrl(String url) {
		driver.get(url);
		
	}
	public static String title() {
		return driver.getTitle();
	}
	public static void goToLogin() {
		driver.findElement(By.xpath("//*[@class='toprow']//*[text()='Login']")).click();
		
	}
	public static void loginUser(String email,String password) {
		driver.findElement(By.xpath("//*[@name='email']")).sendKeys(email);
		driver.findElement(By.xpath("//*[@name='password']")).sendKeys(password);
		driver.findElement(By.xpath("//*[@class='login-buttons']/*[text()='Login']")).click();
		
	}
	public static String verifyUser() {
		return driver.findElement(By.xpath("//*[@class='toprow']//*[text()='Nas']")).getText();
		
	}
	public static void closeBrowser() {
		driver.close();
		
	}
	public static void getFirstItem() {
		driver.findElements(By.xpath("//*[text()='Add to Cart']")).get(0).click();
		
	}

}
