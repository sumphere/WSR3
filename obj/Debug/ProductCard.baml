   M S B A M L   `   `   `  ?????  ;WSR3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WSR3WSR3  5          WSR3.ProductCard   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      $localclr-namespace:WSR3     5        ? DataContext  5	         WSR3.Product  5
   
   .??5      ?  ? ColumnDefinitions 5   
   ?? 5      ?? 5      $
??1.5* ?6   ?? 5      $
??0.8* ?6   .+?5   
   ?? $??0??6   $??15q?6    ??6,   ?? *ProductPhoto+ ?? FallbackValue$ picture.png?? ?? StringFormat$ /Resources/{0}???? 5   
   $??1??6   $??15q?6%   .+?5      ?? $
??Bold"?6   ??6*   ?? *ProductName+?? 5      ??6   ?? *ProductDescription+?? 5      ??6   ?? *ProductManufacturer+$% Производитель: {0}???? 5      ??6   ?? *ProductCost+$ Цена: {0:C}??5      5      5      