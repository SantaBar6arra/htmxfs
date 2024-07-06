module Views.ProjectsView

open Feliz.ViewEngine
open Models

let projectView project =
    Html.div [
        Html.h2 [ prop.text project.Name ]
        Html.p [ prop.text project.Description ]
        Html.a [ prop.href project.Link; prop.text "Link"; prop.target "_blank" ]
    ]

let projectsView (response: ProjectResponse) =
    Html.div (
        [ Html.h1 "Projects"; Html.p "Here are some projects" ]
        @ List.map projectView response.Projects
        @ [
            Html.a [
                prop.href response.ProfileLink
                prop.text "Profile link"
                prop.target "_blank"
            ]
        ]
    )
    |> Render.htmlView
