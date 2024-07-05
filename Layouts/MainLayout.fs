module Layouts.MainLayout

open Feliz.ViewEngine
open Feliz.ViewEngine.Htmx

let mainLayout (body: ReactElement list) =
    Html.html [
        Html.head [
            Html.title "F# ♥ Htmx"
            Html.script [ prop.src "https://unpkg.com/htmx.org@2.0.0" ]
            Html.meta [ prop.charset.utf8 ]
        ]
        Html.body body
    ]
    |> Render.htmlView
