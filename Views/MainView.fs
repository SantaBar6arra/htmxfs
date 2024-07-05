module Views.MainView

open Feliz.ViewEngine
open Feliz.ViewEngine.Htmx

let pageButtons =
    seq { 1..2 }
    |> Seq.map (fun i ->
        Html.button [
            hx.get (sprintf "/page/%d" i)
            hx.swap.innerHTML
            hx.trigger "click"
            hx.target "#page"
            prop.text (sprintf "Page %d" i)
        ])
    |> List.ofSeq

let mainView =
    Html.h1 "HTMX is COOL"
    :: pageButtons
    @ [ Html.div [ prop.id "page" ] ]
