package repository;

import java.lang.*;
import java.util.ArrayList;

import entity.*;
import interfaces.*;

public class RegistrationRepo implements IRegistrationRepo
{
	DatabaseConnection dbc;
	
	public RegistrationRepo()
	{
		dbc = new DatabaseConnection();
	}
	
	public void  insertRegistration(Registration r)
	{
		String query = "INSERT INTO regInfo VALUES ('"+r.getCustomerName()+"','"+r.getEmail()+"','"+r.getAddress()+"','"+r.getPhnNo()+"');";
		try
		{
			dbc.openConnection();
			dbc.st.execute(query);
			dbc.closeConnection();
		}
		catch(Exception ex){System.out.println(ex.getMessage());}
	}
	
	
	/*
	public String[][] getAllOrderInfo()
	{
		ArrayList<Order> ar = new ArrayList<Order>();
		String query = "SELECT * FROM orderinfo;";  
		
		try
		{
			dbc.openConnection();
			dbc.result = dbc.st.executeQuery(query);
			
		
			while(dbc.result.next())
			{
				String orderId = dbc.result.getString("orderId");
				String orderPersonName = dbc.result.getString("orderPersonName");
				double orderAmount = Double.parseDouble(dbc.result.getString("orderAmount"));
				int orderSerial = Integer.parseInt(dbc.result.getString("orderSerial"));
				String orderDate = dbc.result.getString("orderDate");
				
				Order oi = new Order(orderId, orderSerial, orderPersonName, orderAmount, orderDate);
				ar.add(oi);
			}
		}
		catch(Exception e){System.out.println(e.getMessage());}
		dbc.closeConnection();
		
		
		Object obj[] = ar.toArray();
		String data[][] = new String [ar.size()][5];
		
		for(int i=0; i<obj.length; i++)
		{
			data[i][0] = ((Order)obj[i]).getOrderId();
			data[i][1] = (((Order)obj[i]).getOrderSerial()+"");
			data[i][2] = ((Order)obj[i]).getOrderPersonName();
			data[i][3] = (((Order)obj[i]).getOrderAmount()+"");
			data[i][4] = ((Order)obj[i]).getOrderDate();
		}
		
		
		return data;
	}
 */
		
	
}