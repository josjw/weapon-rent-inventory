   M S B A M L   `   `   `  ????  WeaponRental.WPF/    )WeaponRental.WPF.Views.Content.ReportView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .??5      ?   ? RowDefinitions  5   
   ?? 5	      $	??10* ?6   ?? 5
      $	??80* ?6   ?? 5      $	??10* ?6   .+?5   
   ? $??0??6      BrushPrimary2#??[  6    ? ColumnDefinitions 5      ?? 5      $??* ?6#   ?? 5      $??* ?6#   ?? 5      $??* ?6#   .+?5      ?? $??0??6   $??Laporan??6$     HeaderUserControl#??[ 66   5      ? 5   
   $??2??6   #??[  6   ? 5   
   $??1??6   
???????.+?5      ?  ? 	Resources 5       ?? 
TargetType  GroupBoxButton ?? BasedOn??%0   '??       7  ?? 5      " ??6   8   60   5      .+?5      ?? $??Laporan??6   $??15q?6,     HeaderGroupBox#??[ 68   .??5      ?   5      ?? 5       $??30 ?6,   ?? 5!      $??* ?6,   .+?5#      ? $??0??6    5$      ?? 5%   "   $	??15* ?63   ?? 5&   "   $	??85* ?63   .+?5)      ?? -   5         ??Name$ 	BtnSearch??5)   5   $??0??6%   $	??120??6H   $??30??6T   $??10,5,0,0q?6`   $
??Left=?6r   $
??Cari??6?   ?? 5*      -   5         ??Name$ 	TxtSearch??5*   6   $??1??6&   $??20??6I   $??0,5,10,0q?6U   5,      ? 5-      $??1??6   .+?5.      &   System.Windows.Controls.DataGrid  -   5          Name$ ReportDataGrid??5.   '   $??10q?6?      Columns 5/   "   0  *System.Windows.Controls.DataGridTextColumn  50   &   ,  &System.Windows.Controls.DataGridColumn	   Header$	 
No Senjata??69   
   Width5  /System.Windows.Controls.DataGridLengthConverter$	
 120 6M     51   &   $	 
Id Anggota??69   $	
 120 6M     52   &   $	 Id Peminjaman??69   $	
 120 6P     53   &   $	 Status??69   $	
 150 6I   55      56      57      58      59      5:      5;      5<      