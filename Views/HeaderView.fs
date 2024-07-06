module Views.HeaderView

open Feliz.ViewEngine
open Feliz.ViewEngine.Htmx

type Language =
    | En
    | Ua

    [<Literal>]
    static let CodeEn = "en"

    [<Literal>]
    static let CodeUa = "ua"

    static member Value(language) =
        match language with
        | En -> CodeEn
        | Ua -> CodeUa

    static member From(value) : Language option =
        match value with
        | CodeEn -> Some En
        | CodeUa -> Some Ua
        | _ -> None

let languageButton language =
    Html.button [
        hx.get (
            language
            |> Language.Value
            |> sprintf "/language/%s"
        )
        hx.swap.innerHTML
        hx.trigger "click"
        hx.target "#main"
        prop.text (
            language
            |> Language.Value
        )
    ]

let headerButtons = [
    Html.button [
        hx.get "/"
        hx.swap.innerHTML
        hx.trigger "click"
        hx.target "#main"
        prop.text "Home"
    ]
    Html.button [
        hx.get "/projects"
        hx.swap.innerHTML
        hx.trigger "click"
        hx.target "#main"
        prop.text "Projects"
    ]
    Html.button [
        hx.get "/about"
        hx.swap.innerHTML
        hx.trigger "click"
        hx.target "#main"
        prop.text "About"
    ]
    languageButton En
    languageButton Ua
]

let headerView = Html.header [ Html.h1 "My Site Header"; Html.nav headerButtons ]
