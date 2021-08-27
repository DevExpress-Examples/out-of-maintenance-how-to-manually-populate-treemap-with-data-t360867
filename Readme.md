<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128576956/16.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T360867)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* **[Form1.cs](./CS/ItemStorageSample/Form1.cs) (VB: [Form1.vb](./VB/ItemStorageSample/Form1.vb))**
<!-- default file list end -->
# How to: Manually populate TreeMap with data


<p>This example demonstrates how to manually populate TreeMap with data and color the data using a palette colorizer.</p>


<h3>Description</h3>

<p>To manually provide data for TreeMap, assign a newly created instance of the&nbsp;<strong>TreeMapItemStorage</strong>&nbsp;class to the&nbsp;<strong>TreeMapControl.DataAdapter</strong>&nbsp;property. Then, create several&nbsp;<strong>TreeMapItem</strong>&nbsp;objects, specify their Label and Value properties, and add them to the&nbsp;<strong>TreeMapItemStorage.Items</strong>&nbsp;collection.<br>Note that to create a group, you would need to add a new&nbsp;<strong>TreeMapItem</strong>&nbsp;and fill its&nbsp;<strong>Children</strong>&nbsp;collection with tree map&nbsp;items.</p>
<p>To color TreeMap using Palette, assign a&nbsp;<strong>TreeMapPaletteColorizer</strong>&nbsp;object to the&nbsp;<strong>TreeMapControl.Colorizer</strong>&nbsp;property. To color all group items using one color, set the&nbsp;<strong>ColorizeGroups</strong>&nbsp;property of the colorizer to&nbsp;<strong>true</strong>. To specify a palette that should be used to color items, assign an instance of the&nbsp;<strong>Palette</strong>&nbsp;derived class to the&nbsp;<strong>Palette</strong>&nbsp;property of the colorizer.</p>

<br/>


