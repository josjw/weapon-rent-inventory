   M S B A M L   `   `   `  ????  WeaponRental.WPF+    %WeaponRental.WPF.Views.Home.Dashboard   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $
??1300??5      $	??600??6*     ? 
ResizeMode$  	CanResize=?5   	    ? WindowStartupLocation$ CenterScreen=?5   	    ? WindowState$ Normal=?5	   	    ? WindowStyle$ SingleBorderWindow=?5
   	    ? Title$0 *Informasi Peminjaman Senjata ~ [Dashboard]??5   	   .??5      ?    BrushBackground#??[  6    ? RowDefinitions 5   
   ?? 5      $??50 ?6   ?? 5      $??* ?6   .+?5   
   ? $??0??6     BrushPrimary1#??[ 6    ? ColumnDefinitions 5      ?? 5      $	??50* ?6#   ?? 5      $	??50* ?6#   .+?5      ?? $??0??6   $)??#Sistem Informasi Peminjaman Senjata??6$     	HeaderApp#??[ 6R   5      ? 5   
   $??1??6    5      ?? 5      $	??20* ?6#   ?? 5      $	??80* ?6#   .+?5!      ? $??0??6     
BrushMenu1#??[ 6#    5"      ?? 5#      $	??15* ?6$   ?? 5$      $	??85* ?6$   .+?5'      ? $??1??6    ? 	Resources 5(       ?? 
TargetType  	NavButton	 ?? BasedOn??%0   '??       7  ?? 5)      " ??6    8	   64   5*       5+      ?? 5,      $??* ?6(   ?? 5-      $??* ?6(   ?? 5.      $??* ?6(   ?? 5/      $??* ?6(   ?? 50      $??* ?6(   ?? 51      $??* ?6(   ?? 52      $??* ?6(   ?? 53      $??* ?6(   .+?56      ?? -   5        
 ??Name$
 BtnWeaponType??56   *   $??0??6   $??Jenis Senjata??6]   ?? 57      -   5        $
 BtnWeaponData??57   *   $??1??6   $??Data Senjata??6]   ?? 58      -   5        $
 BtnMemberData??58   *   $??2??6   $??Data Anggota??6]   ?? 59      -   5        $
 BtnOfficerData??59   *   $??3??6   $??Data Petugas??6_   ?? 5:      -   5        $
 	BtnBorrow??5:   *   $??4??6   $??
Peminjaman??6U   ?? 5;      -   5        $
 	BtnReturn??5;   *   $??5??6   $??Pengembalian??6U   ?? 5<      -   5        $
 	BtnReport??5<   *   $??6??6   $??Laporan??6U   ?? 5=      -   5        $
 
BtnSetting??5=   *   $??7??6   $??Setting??6W   5>      5?      ]? 5@      -	   5         ]?Name$ 
PnlContent??5@   (   $??1??6   $??10q?6<   5A      5B      5C      