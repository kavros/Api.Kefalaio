# Deploy project locally
* Run `dotnet publish -c Release -r win10-x64`
* Copy publish folder from C:\repos\Api.Kefalaio\Data\bin\Release\net6.0\win10-x64 to remote server


# Performance improvement
* The following index has been added: 
`CREATE NONCLUSTERED INDEX IX_SMAST_SNAME ON [dbo].[SMAST] ([sName])`