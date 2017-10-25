package com.Sugaring;

import org.junit.AfterClass;
import org.junit.Assert;
import org.junit.Test;

public class RegressonTests {

	@Test
	public void canGoToHomePage() {
		Tests.homePage().goTo();
		Assert.assertTrue(Tests.homePage().isAt());
	}
	
	@Test
	public void canLogin() {
		Tests.loginPage().goTo();
		Tests.loginPage().login("nas@nas.nas","atanas");
		Assert.assertTrue(Tests.loginPage().hasUser());
	}
	
	@Test
	public void canPutItemInShopingCard() {
		Tests.homePage().goTo();
		Tests.homePage().selectFirstItem();
		
	}
	
	@AfterClass
	public static void closeBrowser() {
		Tests.close();
	}

}
