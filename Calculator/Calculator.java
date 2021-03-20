import java.lang.*;
import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

public class Calculator extends JFrame
{
	JTextField userTF;
	JButton offBtn, acBtn, mposBtn,mminBtn,mcBtn,mrBtn,oneBtn,twoBtn,threeBtn,fourBtn,fiveBtn,sixBtn,sevenBtn,eightBtn,nineBtn,zeroBtn,pBtn,mBtn,mulBtn,divBtn,tabBtn;
	JPanel panel;
	
	public Calculator()
	{
		super("Calculator ");
		this.setSize(450,800);
		this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		
		panel = new JPanel();
		panel.setLayout(null);
		
		offBtn = new JButton("OFF");
		offBtn.setBounds(50,200,80,50);
		panel.add(offBtn);
		
		
		acBtn = new JButton("AC");
		acBtn.setBounds(210,200,80,50);
		panel.add(acBtn);
		
		
		tabBtn = new JButton("<");
		tabBtn.setBounds(350,200,50,50);
		panel.add(tabBtn);
		
		
		mposBtn = new JButton("M+");
		mposBtn.setBounds(50,275,60,60);
		panel.add(mposBtn);
		
		
		mminBtn = new JButton("M-");
		mminBtn.setBounds(150,200,60,60);
		panel.add(mminBtn);
		
		
		this.add(panel);
		
		
	}
	
}