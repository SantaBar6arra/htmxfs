module Mocks

open Models

let projects: Project list = [
    {
        Id = 1
        Name = "htmxfs"
        Description = "Description 1"
        Link = "https://github.com/santabar6arra/htmxfs"
    }
    {
        Id = 2
        Name = "scss-testing"
        Description = "Description 2"
        Link = "https://github.com/santabar6arra/scss-testing"
    }
]

let projectsResponse: ProjectResponse = {
    Projects = projects
    ProfileLink = "https://github.com/santabar6arra"
}
