   M S B A M L   `   `   `  ���� @  <Poker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PokerPoker      Poker.Settings   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     %localclr-namespace:Poker       � Title$  Settings��$	��600��$	��800�� � Icon$ Images/logo.ico�� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterOwner=�����  �� ImageSource$ Images/settings.jpg�� � 	Resources    	styleName �� 
TargetType �� Triggers P� Property	 P� Value
 �� Property �� Value �� ScaleX �� ScaleY �� 
TargetType ��Name �� CornerRadius��%  &	        �� " �� P�  � ��	 . . ��� 
 � z� �� $
 0.95Q�$
 0.95Q�.��� 
 �@J�RenderTransformOrigin$ 0.5, 0.5&��� 
 � �� �� " ��.R��� $
 brdr��$ 15��#��z��#��z��#��z��#��z��._��� #��z��#��z��#��z���� 
 � ��# � ��.��]� .+��� $
��Left=�$	��400��.+��� $
��Name��$��0,20,0,0q�
������� J� Opacity$	 0.7Q�
���   �$��32(�$��Times New Roman)�$��Center=�$��Black"��� $��Photo��$��0,50,0,0q�
�������$	 0.7Q�
���   �$��32(�$��Times New Roman)�$��Center=�$��Black"��� $��	GameTable��$��0,80,0,0q�
�������$	 0.7Q�
���   �$��32(�$��Times New Roman)�$��Center=�$��Black"��� -    ��Name$ btCancel��#��[  
����  �
��� � �$��	0,220,0,0q�$	��120��$��40��$��Cancel��$��32(�$��Times New Roman)�$��Black"� � Triggers :�  :� RoutedEvent$ 
MouseEnter��.[��� .���� .����  g� Duration$ 0:0:0.5D� �� TargetProperty$ Background.Color�	 �� To$	 RedX��� $ 0:0:0.5D�$ Foreground.Color�$
 BlueX�:� $ 
MouseLeave��.[��� .���� .���� $ 0:0:0.5D�$ Background.Color��� $ 0:0:0.5D�$ Foreground.Color�$
 LimeX��� $��Right=�$	��400��.+��� -    ��Name$ 
PlayerName��$
��Name��$��0,20,0,0q�
�������$	 0.7Q�
���   �$��32(�$��Times New Roman)�$��Center=�$��Black"��� -    ��Name$ playerPhoto��$
��Fill=�$	��100��$	��100��$��0,50,0,0q� J� OpacityMask 
�  
� GradientOrigin$ 0.5,0.5&� 
� Center$ 0.5,0.5&� 
� RadiusX$	 0.5Q� 
� RadiusY$	 0.5Q�.���  � Color$ White��  � Offset$	  1.0Q�� $ Transparent��$	  1.0Q��� -   ! ��Name$! lView��$	��300��$	��110��$	��110��$��0,30,0,0q�
������ $��Center=��� -   $
 btOk��#��[  
����  �
��� � �$��	0,150,0,0q�$	��120��$��40��$��OK��$��32(�$��Times New Roman)�$��Black"� :� $ 
MouseEnter��.[��� .���� .���� $ 0:0:0.5D�$ Background.Color�$
 LimeX��� $ 0:0:0.5D�$ Foreground.Color�$
 BlueX�:� $ 
MouseLeave��.[��� .���� .���� $ 0:0:0.5D�$ Background.Color��� $ 0:0:0.5D�$ Foreground.Color�$
 LimeX�