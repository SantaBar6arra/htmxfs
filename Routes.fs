module Routes

open Suave.Filters
open Suave.Operators
open Suave.Successful
open Layouts.MainLayout
open Views.MainView
open Views.PageView

let mainApp =
    path "/"
    >=> (mainView
         |> mainLayout
         |> OK)

let pageApp =
    pathScan "/page/%d" (fun pageNumber ->
        pageNumber
        |> pageView
        |> OK)
