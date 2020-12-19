package frames;

import java.lang.*;
import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
import java.util.*;

import repository.*;
import entity.*;

public class SalesFrame extends JFrame implements ActionListener
{
	
	private JLabel slNameLabel;
	private JTextField slNameTF;
	private JTable salesInfoTable;
	private JScrollPane salesInfoTableSP;
	private JPanel panel;
	private JButton getAllBtn, backBtn, logoutBtn , deleteBtn;
	
	SalesRepo sr; 
	User user;
	
	
	public SalesFrame(User user){
	   

	    super("Sales Info Frame");
		this.setSize(800, 450);
		this.setResizable(false);
		this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		
		
	    sr = new SalesRepo();
		this.user = user;
		
		
		panel = new JPanel();
		panel.setLayout(null);
		
		
		
		String data[][] = {{"", "", ""}};
		
		String head[] = {"Sales Product Name", "Sales Product Quantity", "Sales Product Amount"};
		
		salesInfoTable = new JTable(data,head);
		salesInfoTableSP = new JScrollPane(salesInfoTable);
		salesInfoTableSP.setBounds(100, 50, 500,200);
		salesInfoTable.setEnabled(false);
		panel.add(salesInfoTableSP);
		
		getAllBtn = new JButton ("Get All Info of Sales");
		getAllBtn.setBounds(250,270, 200, 40);
		getAllBtn.addActionListener(this);
		panel.add(getAllBtn);
		
		
		
		slNameLabel = new JLabel("Sale Product Name");
		slNameLabel.setBounds(260,350,200,30);
		//slNameLabel.setEnabled(false);
		panel.add(slNameLabel);
		
		
		slNameTF = new JTextField();
		slNameTF.setBounds(420,350,80,30);
		//orderIdTF.setEnabled(false);
		panel.add(slNameTF);
		
		
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
			String data[][] = sr.getAllSalesInfo();
			String head[] = {"Sales Product Name", "Sales Product Quantity", "Sales Product Amount"};
			
			panel.remove(salesInfoTableSP);
			
			salesInfoTable = new JTable(data,head);
			salesInfoTable.setEnabled(false);
			salesInfoTableSP = new JScrollPane(salesInfoTable);
			salesInfoTableSP.setBounds(100, 50, 500, 200);
			panel.add(salesInfoTableSP);
			
			panel.revalidate();
			panel.repaint();
			
			deleteBtn.setEnabled(true);
			slNameTF.setEnabled(true);
			
		}
		
		else if(command.equals(deleteBtn.getText()))
		{
			sr.deleteSalesInfoFromDB(slNameTF.getText());
			
			JOptionPane.showMessageDialog(this,"Deleted");
			slNameTF.setText("");
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