// https://suave.io/routing.html

open Suave
open Suave.Filters
open Suave.Operators
open Routes

let app =
    GET
    >=> choose [ mainApp; homeApp; projectsApp; aboutApp ]


startWebServer defaultConfig app
