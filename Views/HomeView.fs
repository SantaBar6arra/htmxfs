module Views.HomeView

open Feliz.ViewEngine

let homeView =
    Html.div [
        Html.h1 "Home"
        Html.p [ prop.id "home"; prop.text "Welcome to my personal home page" ]
    ]
