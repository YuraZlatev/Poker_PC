   M S B A M L   `   `   `  ���� @  <Poker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PokerPoker      Poker.StatusInfo   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     %localclr-namespace:Poker       � Title$  Status��$	��400��$	��600�� � WindowStyle$
 None=� � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=�
����  �$��2q�����  � ColorInterpolationMode$ SRgbLinearInterpolation=�.���  � Color$ 
DarkOrange�� � Offset$	 0.0Q�� $ DarkRed��$	 1.0Q� � 	Resources    	styleName �� 
TargetType	 �� Triggers
 P� Property P� Value �� Property �� Value �� ScaleX �� ScaleY �� 
TargetType ��Name �� CornerRadius��%  &	        �� " ��	 P� 
 � �� . . ���  � z� �� $
 0.95Q�$
 0.95Q�.���  �@J�RenderTransformOrigin$ 0.5, 0.5&���  � �� �� " ��.R��� $
 brdr��$ 15��#��z��#��z��#��z��#��z��._��� #��z��#��z��#��z����  � ��# � ��.��]� .+��� $	��300��.+��� $��0,30,0,0q�$��Center=�$��Money��$��28(�
�������$��
ExtraBlack"��� $��0,30,0,0q�$��Center=�$��	Best Hand��$��28(�
�������$��
ExtraBlack"��� $��	0,130,0,0q�$��Center=�$��Max Bank��$��28(�
�������$��
ExtraBlack"��� -   $��0,20,0,0q�$��Return��#��[  $	��100��$��18(�$��
ExtraBlack"�
����  �
��� � � � Triggers :�  :� RoutedEvent$ 
MouseEnter��.[��� .���� .����  g� Duration$ 0:0:0.5D� �� TargetProperty$ Background.Color�	 �� To$
 LimeX��� .���� .���� $ 0:0:0.5D�$ Foreground.Color�$
 BlueX�:� $ 
MouseLeave��.[��� .���� .���� $ 0:0:0.5D�$ Background.Color��� .���� .���� $ 0:0:0.5D�$ Foreground.Color��� .+��� -    ��Name$ pMoney��$��0,30,0,0q�$��Center=�$	��220��$��28(�
��� ���$��
ExtraBlack"��� -   $ combinationName��$��0,30,0,0q�$��Center=�$��28(�
��� ���$��
ExtraBlack"�� -    �Name$ 	wrapCards��$��70��$��0,30,0,0q�$��Center=�.+��� $��50���� $��50���� $��50���� $��50���� $��50���� -   $ maxBank��$��0,30,0,0q�$��Center=�$	��220��$��28(�
��� ���$��
ExtraBlack"�