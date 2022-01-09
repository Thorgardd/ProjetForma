import Error from "./main/Error";
import Home from "./main/Home";
import Ts from "./main/Ts";
import T from "./main/T";
import Y from "./main/Y";

import React from "react";
import { Navigate } from "react-router-dom";
import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
function Main() {
    return (
        <main>
            <Router>
                <Routes>
                    <Route exact path="/" element={<Navigate to="/T" />} />

                    <Route path="/home" element={<Home />} />

                    <Route path="/T" element={<Ts />} />

                    <Route path="/T/:id" element={<T />} />

                    <Route path="/Y/:id" element={<Y />} />

                    <Route path="*" element={<Error code="404" />} />
                </Routes>
            </Router>
        </main>
    );
}

export default Main;
