select * from Cars
select * from Brands
select * from Colors

SELECT Cars.Id,Brands.BrandName,Colors.ColorName,Cars.ModelYear,Cars.DailyPrice,Cars.Descriptions
FROM ((Cars
INNER JOIN Brands
ON Cars.BrandId = Brands.Id)
INNER JOIN Colors
ON Cars.ColorId = Colors.Id);