   M S B A M L   `   `   `  ����G  CView_Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:View_ProjectView_Project  5   	   A%clr-namespace:View_Project.ViewModelsView_Project.ViewModels  5      5clr-namespace:View_Project.ViewView_Project.View  5   	       View_Project.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:View_Project     5   	   <
Viewmodels%clr-namespace:View_Project.ViewModels     5      0viewclr-namespace:View_Project.View     5   	     � Title$  	Contacts ��5
   	   $	��550��6   $	��800��6(    � WindowStyle$ SingleBorderWindow=�5       � 
ResizeMode$ CanMinimize=�6.    � WindowStartupLocation$ CenterScreen=�5   
    � 	Resources 5       �� DataType)   #View_Project.ViewModels.AddContacts   View_Project.View.AddCon � DataContext)   #View_Project.ViewModels.EditContact   View_Project.View.Edit��%�   (��       5   3   *, +)(�� W     5   4   *, +)�� 5   
   AddContactTemplate��"  63   .R�5         6   �� 5      �� 5   
   EditContactTemplate��"  64   .R�5         6   �� 5      5      .��5       � $��0,0,3.6,-19.2q�5!   	    � RowDefinitions 5"   
   �� 5#      �� 5$      $
��539* �6   .+�5&   
   �� $	��790��6   $
��Wrap=�5'   
   $��55��6   $��Center=�5(      $	��Top=�61   $
��Bold"�6I   $��Italic$�6[   $��36(�5)       �� TextAlignment$ Center=�6"   $��2��69   �� 6K   $$�Welcome To Contact Application��6O   6x   �� 5,   
   $
��Left=�6   $
��32.4��5-      $��
0,59.4,0,0q�6    $��1��5.      	 �� TextWrapping$
	 Wrap=�5/      $0��*Please Select One of the Following Options��50      $	��Top=�51      $	��780��52      
 �� TextAlignment$
 Center=�53       � UseLayoutRounding .  $��Sitka Banner)�55      $��18(�56      
�������6    �� 57   
   $
��Left=�6   $	��313��60   $��10,156.2,0,0q�6=   $��1��6S   $	��Top=�6`   $	��143��6x    J� RenderTransformOrigin$ 0.5,0.5&�6�   z�58      V� 59      .~�5:      �� �� 5;      �� 5<       �� Angle$ -0.109Q�6&   T� 5=      5>      .+�5@      �� -   5         ��Name$ Add_Contact��5@      $��Add Contact��6*   $
��Left=�6@   $��43��6[   $��10,0,0,0q�6g   $	��122��6y   $	��Top=�6�   $ 0.287,0.548&�6�   �� 5A      -   5        $ Edit_Contact��5A      $��Edit Contact��6+   $
��Left=�6B   $��43��6]   $��	10,12,0,3q�6i   $	��122��6|   $	��Top=�6�   6�   �� 5B      -   5        $ Delete_Contact��5B      $��Delete Contact��6-   $
��Left=�6F   $��43��6a   $��	10,12,0,3q�6m   $	��122��6�   $	��Top=�6�   6�   �� 5C      -   5        $ Search_Contact��5C      $��Search Contact��6-   $
��Left=�6F   $��43��6a   $��	10,12,0,3q�6m   $	��122��6�   $	��Top=�6�   6�   �� 5D      -   5        $ Sort_Contact��5D      $��Sort Contact��6+   $
��Left=�6B   $��43��6]   $��	10,12,0,3q�6i   $	��122��6|   $	��Top=�6�   6�   5E      �� 5F   
   -   5         ��Name$ Content_Show��5F      $
��Left=�6C   $	��354��6^   $	��Top=�6k   $��192,116.2,0,0q�6�   $��1��6�   $	��531��6�   ��6/   �� 6�   �� 5G   
   $
��Left=�6   $	��100��60   $��2��6=   $	��Top=�6N   $	��100��6f   5H      5J      