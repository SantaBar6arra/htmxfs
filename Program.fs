// https://suave.io/routing.html

open Suave
open Suave.Filters
open Suave.Operators
open Routes

let app =
    GET
    >=> choose [ mainApp; pageApp ]


startWebServer defaultConfig app
