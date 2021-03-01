﻿(*** condition: prepare ***)
#r "../../bin/XPlot.GoogleCharts/netstandard2.0/XPlot.GoogleCharts.dll"
#r "../../packages/Newtonsoft.Json/lib/netstandard2.0/Newtonsoft.Json.dll"
#r "../../packages/Google.DataTable.Net.Wrapper/lib/netstandard2.0/Google.DataTable.Net.Wrapper.dll"
(*** condition: ipynb ***)
#if IPYNB
#r "nuget: XPlot.GoogleCharts"
#endif // IPYNB

(**
Google Stepped Area Chart
=========================
*)
open XPlot.GoogleCharts

let data =
    [
        [
            "Alfred Hitchcock (1935)", 8.4
            "Ralph Thomas (1959)", 6.9
            "Don Sharp (1978)", 6.5
            "James Hawes (2008)", 4.4
        ]
        [
            "Alfred Hitchcock (1935)", 7.9
            "Ralph Thomas (1959)", 6.5
            "Don Sharp (1978)", 6.4
            "James Hawes (2008)", 6.2
        ]
    ]

let options =
    Options(
        title = "The decline of 'The 39 Steps'",
        vAxis = Axis(title = "Accumulated Rating"),
        isStacked = true
    )

let chart =
    data
    |> Chart.SteppedArea
    |> Chart.WithOptions options
    |> Chart.WithLabels ["Rotten Tomatoes"; "IMDB"]
(*** hide ***)
chart.GetHtml()
(*** include-it-raw ***)
