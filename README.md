# SpareParts
零配件管理


## 开发采用C# balzor web 
## 数据库使用 sqllite
## 备件的 model 除备件ID外，全部可为空
public class 备件动态
 {
     [Required]
     public Guid 备件ID { get; set; }
     public string 物品编码 { get; set; } = "";
     public string 备件名称 { get; set; } = "";
     public string 物资类别 { get; set; } = "";
     public string 常用件类别 { get; set; } = "";
     public string 单位 { get; set; } = "";
     public int 统计数量 { get; set; } = 0;
     public int 结存数量 { get; set; } = 0;
     public double 单价 { get; set; } = 0.0;
     public double 金额 { get; set; } = 0.0;
     public string 仓库位置 { get; set; } = "";
     public string 货架位置 { get; set; } = "";
     public string 规格型号 { get; set; } = "";
     public string 供应商 { get; set; } = "";
     public string 滞留原因 { get; set; } = "";
     public string 使用设备 { get; set; } = "";
     public string 入库年份 { get; set; } = "";
     public string 预计使用日期 { get; set; } = "";
     public string 备注 { get; set; } = "";
     public string 品牌 { get; set; } = "";
     public string 申报人 { get; set; } = "";
     public DateTime? 申报日期 { get; set; }
     public DateTime? 到货日期 { get; set; }
     public Guid 点检维修ID { get; set; }
     public string 维修人员 { get; set; } = "";
     public DateTime? 领用时间 { get; set; }
     public string 领用人 { get; set; } = "";

 }
 ###运行在本地5003端口，开放访问
 ### page1 查看所有备件的列表， 有个搜索框，可以根据 物品编码、备件名称、物品类别等等进行搜索。列表上，设置 一组checkbox ，用以开启或关闭 此列是否显示。
 ### page2 录入备件，可以方便快速的录入所有备件
