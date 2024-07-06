module Views.AboutView

open Feliz.ViewEngine

let aboutView =
    Html.div [
        Html.h1 "About"
        Html.p [ prop.id "about"; prop.text "My name is Rodrigo Caracas." ]
        Html.img [
            prop.src "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS22DgZwQioAecKwvuaklGLo_IwYZ6tUfor4g&s"
            prop.alt "Rodrigo Caracas"
        ]
        Html.p [ prop.text "me asf." ]
    ]
    |> Render.htmlView
