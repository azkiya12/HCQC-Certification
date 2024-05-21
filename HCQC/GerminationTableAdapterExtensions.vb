Imports System.Threading.Tasks
Imports WindowsApplication1.HCQC_NewDatasetTableAdapters

Public Module GerminationTableAdapterExtensions
    <System.Runtime.CompilerServices.Extension()>
    Public Async Function FillAsync(tableAdapter As germinationTableAdapter, dataSet As HCQC_NewDataset, fillterStr As String, fillterStr2 As String) As Task
        Await Task.Run(Sub() tableAdapter.FillByStr(dataSet.germination, fillterStr, fillterStr2))
    End Function

End Module

