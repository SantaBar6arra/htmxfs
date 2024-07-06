module Routes

open Suave.Filters
open Suave.Operators
open Suave.Successful
open Layouts.MainLayout
open Views.MainView
open Views.ProjectsView
open Mocks
open Views.HomeView
open Feliz.ViewEngine
open Views.AboutView

let mainApp =
    path "/"
    >=> (mainView
         |> mainLayout
         |> OK)

let homeApp =
    path "/home"
    >=> OK(
        homeView
        |> Render.htmlView // TODO: is it a good idea to use Render.htmlView here?
    )

let projectsApp =
    path "/projects"
    >=> (projectsResponse
         |> projectsView
         |> OK)

let aboutApp =
    path "/about"
    >=> OK aboutView
