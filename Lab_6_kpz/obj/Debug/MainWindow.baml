   M S B A M L   `   `   `  ����D  @Lab_6_kpz, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Lab_6_kpz	Lab_6_kpz  5   	       Lab_6_kpz.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Lab_6_kpz     5   	   -   5          � Title$  
MainWindow��5	   	   $	��450��6   $	��870��6)   .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DGrid��5   /      AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Surname��6A      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6R   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *	Surname+6R     5      $
 Name��6>   $
 Auto 6L    6%   �� *Name+6L     5      $ 
MiddleName��6E   $
 Auto 6Y    6%   �� *MIddle_name+6Y     5      $ PhoneNumber��6F   $
 Auto 6[    6%   �� *Phone_number+6[     5      $ 	DateBirth��6d   $
 Auto 6w    6%   �� *
Date_birth+ �� StringFormat$ {0:dd/MM/yyyy }��6w     5      $ Email��6?   $
 Auto 6N    6%   �� *Email+6N     5      $ RegistrationDate��6k   $
 Auto 6�    6%   �� *Registration_date+$ {0:dd/MM/yyyy }��6�   5      �� 5   
   $��Center=�6   $��1��62   	 �� Orientation$	 
Horizontal=�6?   .+�5      �� -   5        
 ��Name$
 updateButton��5      $��Update��6+   $��10q�6W   $��80��6c   �� 5      -   5        $
 deleteButton��5      $��Delete��6+   $��10q�6W   $��80��6c   �� 5      -   5        $
 OtherWindowButton��5      $��ADO.NET��60   $��10q�6b   $��80��6n   5      5       5!      