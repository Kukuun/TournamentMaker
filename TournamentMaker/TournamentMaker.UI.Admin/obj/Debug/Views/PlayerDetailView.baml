   M S B A M L   `   `   `  ����S  OTournamentMaker.UI.Admin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:TournamentMaker.UI.Admin.ViewsTournamentMaker.UI.Admin.Views  5      5    /TournamentMaker.UI.Admin.Views.PlayerDetailView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      >local,clr-namespace:TournamentMaker.UI.Admin.Views     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��Player info��6   $
��Bold"�6&   $��18(�68   $��5q�6F   �� 5   
   $��1��6   $
��Left=�6   $	��200��69   
������ 
���   �$��1q�5   >   ._�5      �� $��5��6   $
��Left=�6*   .+�5      �� $��
Firstname:��6   $��2q�6-   �� 5       �� 
IsReadOnly . $	��100��5   ,   $��5q�68   ��5      �� *Player.FirstName+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5   8   �� 5      $��Alias:��6   $��2q�6)   �� 5       . $	��100��5   ,   $��5q�69   ��5      �� *Player.Alias+$ TwoWay=�$ PropertyChanged=�5   9   �� 5      $��	Lastname:��6   $��2q�6,   �� 5       . $	��100��5   ,   $��5q�69   ��5      �� *Player.LastName+$ TwoWay=�$ PropertyChanged=�5   9   �� 5!      $��Phone:��6   $��2q�6)   �� 5"       . $	��100��5#   ,   $��5q�69   ��5"      �� *Player.PhoneNumber+$ TwoWay=�$ PropertyChanged=�5#   9   �� 5%      $��Mail:��6   $��2q�6(   �� 5&       . $	��100��5'   ,   $��5q�69   ��5&      �� *Player.Mail+$ TwoWay=�$ PropertyChanged=�5'   9   �� 5)      $��Teams:��6   $��2q�6)   y�64   �� *	HasTeam+�� 5*      $	��100��69   $
��Left=�5+       �� DisplayMemberPath$ DisplayMember��5,      {�.  $��12(�5/      $��5q�50      ��5*      �� *Teams+y�5-      �� *	HasTeam+50      51      52      53      54      