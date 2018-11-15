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


