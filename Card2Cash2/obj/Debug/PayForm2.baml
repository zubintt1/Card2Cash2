   M S B A M L   `   `   `  ����  
Card2Cash2    Card2Cash2.PayForm2   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Welcome��5   	   $��444.03��6   $��545.896��6)    � WindowStartupLocation$ CenterScreen=�69    J� SnapsToDevicePixels .  � WindowStyle$ 
ToolWindow=�6y   ��5      �� 5   
    �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6/   .��5      �  � Color$ Black��6    � Offset$ 0Q�6)   � 5      $ 	#FF46A43C��6   $ 1Q�6-   5	       � 	Resources 5      	 �� MergedDictionaries
 �� Source�� 5   
   	 5      �� 5      $
 GlassButton.xaml?�6%   %    5      .��5      � $
��Left=�6   $	��405��6&   $��
0,10,-7,-1q�63   $	��Top=�6G   $	��545��6_   .+�5   
   �� -   5         ��Name$ request_lbl4��5      $&�� Please provide your phone number��6&   $
��Left=�6Q   $��	23,23,0,0q�6l   $	��Top=�6   $	��293��6�   ���	#FFADB657$��Times New Roman)�6�   $��20(�6�   �� 5   
   -   5         ��Name$ numver_txtbx3��5      $
��Left=�6)   $��33��6D   $��
367,23,0,0q�6P    �� TextWrapping$
 Wrap=�6d   $	��Top=�6x   $	��128��6�    J� RenderTransformOrigin$ 
0.72,0.965&�6�   ���	#FF1D1DAE$��Times New Roman)�6�   $��24(�6�   �� 5   
   -   5        $ request_lbl5��5      $!��Please enter the OTP Number��6&   $
��Left=�6L   $��	23,85,0,0q�6g   $	��Top=�6z   $	��293��6�   ���	#FFADB657$��Times New Roman)�6�   $��20(�6�   �� 5   
   -   5        $ otpver_txtbx1��5      $
��Left=�6)   $��33��6D   $��
367,85,0,0q�6P   $
 Wrap=�6d   $	��Top=�6x   $	��128��6�   $ 
0.72,0.965&�6�   ���	#FF1D1DAE$��Times New Roman)�6�   $��24(�6�   �� 5   
   -   5        $ request_lbl6��5      $(��"Please enter the amount to be paid��6&   $
��Left=�6S   $��
23,149,0,0q�6n   $	��Top=�6�   $	��293��6�   ���	#FFADB657$��Times New Roman)�6�   $��20(�6�   �� 5   
   -   5        $ amount_txtbx1��5      $
��Left=�6)   $��33��6D   $��367,149,0,0q�6P   $
 Wrap=�6e   $	��Top=�6y   $	��128��6�   $ 
0.72,0.965&�6�   ���	#FF1D1DAE$��Times New Roman)�6�   $��24(�6�   �� 5   
   -   5         ��Name$ 	back_btn2��5         RoundCorner#��[  6$   $
��Back��6I   $
��Left=�6X   $��
23,203,0,0q�6s   $	��Top=�6�   $��75��6�   $��42��6�   6�   �� 5   
   -   5        $ pay_btn2��5      #��[  6#   $	��Pay��6H   $
��Left=�6V   $��420,203,0,0q�6q   $	��Top=�6�   $��75��6�   $��42��6�   6�   �� 5   
   -	   5         ��Name$ result_txtbx2��5      $
��Left=�6+   $��
23,262,0,0q�6F   $
��Wrap=�6Z   $	��Top=�6n   $��93��6�   $	��472��6�   �� 5   
   -
   5        $ Failure_lbl2��5      $��Failure��6&   $
��Left=�68   $��
23,360,0,0q�6S   $	��Top=�6g   $��75��6   ���	#FF9C0404$��Times New Roman)�6�   $��20(�6�   $y�Hidden=�6�   �� 5   
   -   5        $ Success_lbl2��5      $��Success��6&   $
��Left=�68   $��420,360,0,0q�6S   $	��Top=�6h   $��75��6�   ���	#FF0007A2$��Times New Roman)�6�   $��20(�6�   $y�Hidden=�6�   5"      5#      