import React from 'react'
import { Link } from 'react-router-dom'

export default function Navbar() {
    return (
        <nav class="navbar bg-body-tertiary">
            <div class="container-fluid">
                <Link class="navbar-brand" to={"/"}>Típusok</Link>
                 <Link className="nav-link" to={"/uj-tip"}>Új típusok</Link>
            </div>
        </nav>
    )
}
