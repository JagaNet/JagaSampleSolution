..\packages\OpenCover.4.6.519\tools\OpenCover.Console.exe  -target:"C:\Program Files (x86)\Microsoft Visual Studio\2017\Community\Common7\IDE\mstest.exe" -output:"coverage.xml" -targetargs:"/testcontainer:.\bin\debug\Jaga.Sample.Data.Tests.dll" -filter:"+[Jaga.Sample.Data]*"  -register:user
..\packages\ReportGenerator.3.0.2\tools\ReportGenerator.exe "-reports:coverage.xml" "-targetdir:CoverageReport"


