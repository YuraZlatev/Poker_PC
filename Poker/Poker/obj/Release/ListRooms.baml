   M S B A M L   `   `   `  ���� @  <Poker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PokerPoker      Poker.ListRooms   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     %localclr-namespace:Poker       � Title$  Список комнат��$	��500��$	��300�� � WindowStyle$
 None=� � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=�
����  �$��2q�����  �� ImageSource$ Images/listrooms.jpg�� � 	Resources    	styleName �� 
TargetType �� Triggers P� Property	 P� Value
 �� Property �� Value �� ScaleX �� ScaleY �� 
TargetType ��Name �� CornerRadius��%  &	        �� " �� P�  � ��	 . . ��� 
 � z� �� $
 0.85Q�$
 0.85Q�.��� 
 �@J�RenderTransformOrigin$ 0.5, 0.5&��� 
 � �� �� " ��.R��� $
 brdr��$ 15��#��z��#��z��#��z��#��z��._��� #��z��#��z��#��z���� 
 � ��# � ��.���� .+��� $,��&№               Players at the table��$��	10,10,0,0q�$��18(�
��� ����� -    ��Name$ lbRooms��
������ $	��280��$	��360��$��0,0,0,0q�
����  �$��18(��� -    ��Name$ ok��#��[  $
��ОК��$	��100��$��30��
��� � �
����  �$��	ExtraBold"�$��
0,40,120,0q�$��18(� � Triggers :�  :� RoutedEvent$ 
MouseEnter��.[��� .���� .����  g� Duration$ 0:0:0.5D� �� TargetProperty$ Background.Color�	 �� To$
 LimeX��� $ 0:0:0.5D�$ Foreground.Color�$
 BlueX�:� $ 
MouseLeave��.[��� .���� .���� $ 0:0:0.5D�$ Background.Color��� $ 0:0:0.5D�$ Foreground.Color��� -   $ cancel��#��[  $��Cancel��$	��100��$��30��
��� � �
����  �$��	ExtraBold"�$��120,-30,0,0q�$��18(� :� $ 
MouseEnter��.[��� .���� .���� $ 0:0:0.5D�$ Background.Color�$	 RedX��� $ 0:0:0.5D�$ Foreground.Color�$
 BlueX�:� $ 
MouseLeave��.[��� .���� .���� $ 0:0:0.5D�$ Background.Color��� $ 0:0:0.5D�$ Foreground.Color�