package com.example.plugins
import java.io.File

import io.ktor.server.application.*
import io.ktor.server.response.*
import io.ktor.server.routing.*

fun Application.configureRouting() {
    routing {
        get("/") {
            call.respondFile(File("templates"), "index.html")
        }
    }
}
