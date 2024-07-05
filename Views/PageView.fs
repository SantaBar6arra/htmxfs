module Views.PageView

open Feliz.ViewEngine

let pageView pageNumber =
    Html.div [
        Html.h1 "Page"
        Html.p [ prop.id "page"; prop.text (sprintf "Page %d" pageNumber) ]
    ]
    |> Render.htmlView
