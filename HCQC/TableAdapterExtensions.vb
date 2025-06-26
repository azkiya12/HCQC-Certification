Imports System.Threading.Tasks
Imports System.Runtime.CompilerServices
Imports WindowsApplication1.HCQC_NewDatasetTableAdapters

Module TableAdapterExtensions
    'Modul ini di gunakan untuk interaksi dengan database
    'secara Asyncronus sehingga tidak menimbulkan loading bufering

    <Extension()>
    Public Function FillAsync(adapter As report_global_viewTableAdapter, dataset As HCQC_NewDataset) As Task
        Return Task.Run(Sub() adapter.FillByLastYear(dataset.report_global_view))
    End Function

    <Extension()>
    Public Function FillAsync(adapter As viabilityTableAdapter, dataset As HCQC_NewDataset, fillterStr As String, fillterStr2 As String) As Task
        Return Task.Run(Sub() adapter.FillByStr(dataset.viability, fillterStr, fillterStr2))
    End Function

    <Extension()>
    Public Function FillAsync(adapter As rafactionTableAdapter, dataset As HCQC_NewDataset, fillterStr As String, fillterStr2 As String) As Task
        Return Task.Run(Sub() adapter.FillByStr(dataset.rafaction, fillterStr, fillterStr2))
    End Function

    <Extension()>
    Public Function FillAsync(adapter As moistureTableAdapter, dataset As HCQC_NewDataset, fillterStr As String, fillterStr2 As String) As Task
        Return Task.Run(Sub() adapter.FillByStr(dataset.moisture, fillterStr, fillterStr2))
    End Function

    <Extension()>
    Public Function FillAsync(adapter As purityTableAdapter, dataset As HCQC_NewDataset, fillterStr As String, fillterStr2 As String) As Task
        Return Task.Run(Sub() adapter.FillByStr(dataset.purity, fillterStr, fillterStr2))
    End Function

    <Extension()>
    Public Function FillAsync(adapter As archiveTableAdapter, dataset As HCQC_NewDataset, fillterStr As String, fillterStr2 As String) As Task
        Return Task.Run(Sub() adapter.FillByStr(dataset.archive, fillterStr, fillterStr2))
    End Function



End Module

