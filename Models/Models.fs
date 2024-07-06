module Models

type Project = {
    Id: int
    Name: string
    Description: string
    Link: string
}

type ProjectResponse = {
    Projects: Project list
    ProfileLink: string
}

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
