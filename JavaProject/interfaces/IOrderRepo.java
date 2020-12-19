package interfaces;

import java.lang.*;

import entity.*;

public interface IOrderRepo
{
	
	void insertOrderInformation(Order o);
	void deleteOrderInfoFromDB(String orderId);
	public String[][] getAllOrderInfo();
	
}