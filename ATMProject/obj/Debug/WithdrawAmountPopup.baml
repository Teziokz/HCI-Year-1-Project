   M S B A M L   `   `   `  ����E  AATMProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:ATMProject
ATMProject  5   	   %    ATMProject.WithdrawAmmountPopup   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:ATMProject     5   	     � WindowStyle$
  None=�5   	    � WindowStartupLocation$ CenterScreen=�5	   	    � AllowsTransparency .  � Title$ WithdrawAmmountWindow��5   	   $	��850��6'   $	��700��64   
���   �.��5      � $	��700��6   $	��850��6   
�������.+�5   
   �� ���	#FF0A8DD8$��20q�6)   ._�5      �� -   5        $��X��5      $��0q�6    ���	#FFB62525$��75��6B   $��75��6M   $��Right=�6Y   $	��Top=�6u   $��Center=�6�   $��Center=�6�   $��48(�6�   $
��Bold"�6�   
����������	#FF801B1B$��0,0,0,5q�69  5      � 5   
   -   5         �Name$ authenticator��5      $	��710��6&   $��0,0,0,20q�63   $��Bottom=�6E   $	��590��6`   $y�Visible=�6l   $��Center=�6�    � RowDefinitions 5      �� 5      $	��200 �6    �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5      �� 5      �� 5      �� 5      .+�5      �� -   5        $��1��5      $��10q�6    $��1��6,   $��72(�69   $��Center=�6G   $��Center=�6k   ���	#FF0A8DD8
����������	#FF095E8F$��0,0,5,5q�6�   �� 5      -   5        $��2��5      $��10q�6    $��1��6,   $��72(�69   $��1��6G   $��Center=�6W   $��Center=�6{   ���	#FF0A8DD8
����������	#FF095E8F$��0,0,5,5q�6�   �� 5      -   5        $��3��5      $��10q�6    $��1��6,   $��72(�69   $��2��6G   $��Center=�6W   $��Center=�6{   ���	#FF0A8DD8
����������	#FF095E8F$��0,0,5,5q�6�   �� 5       -   5        $��4��5       $��10q�6    $��2��6,   $��72(�69   $��Center=�6G   $��Center=�6k   ���	#FF0A8DD8
����������	#FF095E8F$��0,0,5,5q�6�   �� 5!      -   5        $��5��5!      $��10q�6    $��2��6,   $��72(�69   $��1��6G   $��Center=�6W   $��Center=�6{   ���	#FF0A8DD8
����������	#FF095E8F$��0,0,5,5q�6�   �� 5"      -   5        $��6��5"      $��10q�6    $��2��6,   $��72(�69   $��2��6G   $��Center=�6W   $��Center=�6{   ���	#FF0A8DD8
����������	#FF095E8F$��0,0,5,5q�6�   �� 5#      -	   5        $��7��5#      $��10q�6    $��3��6,   $��72(�69   $��Center=�6G   $��Center=�6k   ���	#FF0A8DD8
����������	#FF095E8F$��0,0,5,5q�6�   �� 5$      -
   5        $��8��5$      $��10q�6    $��3��6,   $��72(�69   $��1��6G   $��Center=�6W   $��Center=�6{   ���	#FF0A8DD8
����������	#FF095E8F$��0,0,5,5q�6�   �� 5%      -   5        $��9��5%      $��10q�6    $��3��6,   $��72(�69   $��2��6G   $��Center=�6W   $��Center=�6{   ���	#FF0A8DD8
����������	#FF095E8F$��0,0,5,5q�6�   �� 5&      -   5        $��X��5&      $��10q�6    $��4��6,   $��72(�69   $��Center=�6G   $��Center=�6k   ���	#FFD86618
�������$��0,0,5,5q�6�   ���	#FF8B44136�   �� 5'      -   5        $��0��5'      $��10q�6    $��4��6,   $��72(�69   $��1��6G   $��Center=�6W   $��Center=�6{   ���	#FF0A8DD8
����������	#FF095E8F$��0,0,5,5q�6�   �� 5(      -   5         ��Name$ confirmButton��5(      $	��✔��6+   $��10q�67   $��4��6C   $��72(�6P   $��2��6^   $��Center=�6n   $��Center=�6�   ���	#FF4BC937
�������$��0,0,5,5q�6�   ���	#FF1B99076  �� 5)      -   5         ��Name$ amountOutput��5)      $��10q�6,   	 �� TextWrapping$
	 Wrap=�68   $��3��6L   $	��150(�6`   $��68,1,1,1q�6o   $��Consolas)�6�   $
��Bold"�6�   $��5q�6�   ���	#FF092D4B
�������
 �� TextDecorations
 6�   Z� 6�   5*      5+      5,      