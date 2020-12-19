package frames;

import java.lang.*;
import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
import java.util.*;

import repository.*;
import entity.*;

public class OrderInfoFrame extends JFrame implements ActionListener
{
	
    private JLabel orderIdLabel;
	private JTextField orderIdTF;
	private JTable OrderInfoTable;
	private JScrollPane OrderInfoTableSP;
	private JPanel panel;
	private JButton getAllBtn, backBtn, logoutBtn, deleteBtn;
	
	OrderRepo or; 
	User user;
	
	
	public OrderInfoFrame(User user){
	   

	    super("CustomerInfoFrame");
		this.setSize(800, 450);
		this.setResizable(false);
		this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		
		
	    or = new OrderRepo();
		this.user = user;
		
		
		panel = new JPanel();
		panel.setLayout(null);
		
		
		
		String data[][] = {{"", "", "", "", ""}};
		
		String head[] = {"Order Id", "Order Setrial", "Order Person Name", "Order Amount", "Order Date"};
		
		OrderInfoTable = new JTable(data,head);
		OrderInfoTableSP = new JScrollPane(OrderInfoTable);
		OrderInfoTableSP.setBounds(100, 50, 500,200);
		OrderInfoTable.setEnabled(false);
		panel.add(OrderInfoTableSP);
		
		getAllBtn = new JButton ("Get All InfO of Order");
		getAllBtn.setBounds(250,270, 200, 40);
		getAllBtn.addActionListener(this);
		panel.add(getAllBtn);
		
		orderIdLabel = new JLabel("Order Id");
		orderIdLabel.setBounds(210,350,80,30);
		orderIdLabel.setEnabled(false);
		panel.add(orderIdLabel);
		
		
		orderIdTF = new JTextField();
		orderIdTF.setBounds(300,350,80,30);
		//orderIdTF.setEnabled(false);
		panel.add(orderIdTF);
		
		
		deleteBtn = new JButton("Delete");
		deleteBtn.setBounds(470,270,80,30);
		deleteBtn.addActionListener(this);
		deleteBtn.setEnabled(false);
		panel.add(deleteBtn);
		
		
		backBtn = new JButton ("<<Back");
		backBtn.setBounds(80, 350, 100, 30);
		backBtn.addActionListener(this);
		panel.add(backBtn);
		
		logoutBtn = new JButton ("LogOut");
		logoutBtn.setBounds(600, 350, 80, 40);
		logoutBtn.addActionListener(this);
		panel.add(logoutBtn);
			
		this.add(panel);
		
	}
	
	public void actionPerformed(ActionEvent ae)
	{
		String command = ae.getActionCommand();
	
	
		if(command.equals(getAllBtn.getText()))
		{
			String data[][] = or.getAllOrderInfo();
			String head[] = {"Order Id", "Order Serial", "Order Persno Name", "Order Amount", "Order Date"};
			
			panel.remove(OrderInfoTableSP);
			
			OrderInfoTable = new JTable(data,head);
			OrderInfoTable.setEnabled(false);
			OrderInfoTableSP = new JScrollPane(OrderInfoTable);
			OrderInfoTableSP.setBounds(100, 50, 500, 200);
			panel.add(OrderInfoTableSP);
			
			panel.revalidate();
			panel.repaint();
			
			orderIdLabel.setEnabled(true);
			deleteBtn.setEnabled(true);
			
		}
		
		else if(command.equals(deleteBtn.getText()))
		{
			or.deleteOrderInfoFromDB(orderIdTF.getText());
			
			JOptionPane.showMessageDialog(this,"Deleted");
	
			//loadBtn.setEnabled(true);	
		}
		
		
		
		
		else if(command.equals(backBtn.getText()))
		{
			
			EmployeeHome eh = new EmployeeHome(user);
			eh.setVisible(true);
			this.setVisible(false);
			
		}
		
		else if(command.equals(logoutBtn.getText()))
		{
			LoginFrame lf = new LoginFrame();
			lf.setVisible(true);
			this.setVisible(false);
		}
		
		
		else{};
	}
		
}