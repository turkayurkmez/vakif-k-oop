// See https://aka.ms/new-console-template for more information
using Builder;

Console.WriteLine("Hello, World!");
/*
 * PROBLEM:
 * 
 *   Karmaşık süreçlerden geçerek oluşan bir nesneniz var. Bu aşamalar, zamanla değişebilir ve artabilir ancak elde nesne aynıdır. Bu karmaşayı düzenlemek için ne yapmalı?
 *   
 *   Senaryo:
 *  Bir web uygulamasında; kullanıcılar, çeşitli verileri girerek rapor oluşturacaklardır. Onlarca veri ve kombinasyon tek bir raporu inşa edecektir. Veriler ya da rapor parçaları değişebilir. Bütün bu kaosta SOLID prensiplerine uyabilmek için  rapor builder ile üretilmedlidir.
 */

ReportCreator reportCreator = new ReportCreator();
reportCreator.ReportBuilder = new PerformanceReportBuilder();
var report = reportCreator.BuildReport();
Console.WriteLine(report);