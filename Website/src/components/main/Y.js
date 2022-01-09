import { useParams } from "react-router";
import Why from "../../mock/_y_987.json";
import Error from "./Error";
import "../../styles/main/Y.css";
import { useState } from "react";
import Hpop from "./H-pop";
import Ypop from "./Y-pop";

function Hlist() {
    const [ypop, setypop] = useState(false);
    const [hpop, sethpop] = useState(false);
    const [hidpop, sethidpop] = useState(undefined);
    const [contentpop, setcontentpop] = useState(undefined);
    const popupCloseHandler = () => {
        sethpop(false);
        setypop(false);
        sethpop(undefined);
        setcontentpop(undefined);
    };

    return (
        <div className="Ymap">
            {ypop && (
                <Ypop
                    name={Why.why.name}
                    description={Why.why.description}
                    codesample={Why.why.codesample}
                    yid={Why.why.yid}
                    onClose={popupCloseHandler}
                    show={ypop}
                />
            )}

            {hpop && (
                <Hpop
                    hid={hidpop}
                    content={contentpop}
                    onClose={popupCloseHandler}
                    show={hpop}
                />
            )}

            <div className="lead">
                <div
                    className="gallery y"
                    style={
                        Why.why.status === "invalid"
                            ? { borderColor: "var(--invalid)" }
                            : Why.why.status === "valid"
                            ? { borderColor: "var(--valid)" }
                            : { borderColor: "var(--pending)" }
                    }
                >
                    <div className="head">
                        <img
                            className="avatar"
                            src={
                                "https://avatars.dicebear.com/api/open-peeps/" +
                                Why.why.partner +
                                ".svg"
                            }
                            alt={"Logo de " + Why.why.name}
                        />
                        <p className="name">{Why.why.partner}</p>

                        <svg
                            className="edit"
                            width="20"
                            height="20"
                            viewBox="0 0 20 20"
                            fill="currentColor"
                            onClick={() => setypop(true)}
                        >
                            <path d="M16.77 8l1.94-2a1 1 0 0 0 0-1.41l-3.34-3.3a1 1 0 0 0-1.41 0L12 3.23zm-5.81-3.71L1 14.25V19h4.75l9.96-9.96-4.75-4.75z" />
                        </svg>
                    </div>
                    <h2>{Why.why.name}</h2>
                    <p>{Why.why.description}</p>
                    <div className="syntax">
                        <code>{Why.why.codesample}</code>
                    </div>
                </div>

                <div className="gallery neutral">
                    <p>Vous avez la réponse ?</p>
                    <div className="add" onClick={() => sethpop(true)}>
                        +
                    </div>
                </div>
            </div>

            <div className="Hs">
                {Why.Helps.map((element, key) => {
                    return (
                        <div
                            key={key}
                            className="gallery neutral"
                        >

                            <div className="H">
                                <div className="head">
                                    <svg
                                        className="edit"
                                        width="20"
                                        height="20"
                                        viewBox="0 0 20 20"
                                        fill="currentColor"
                                        onClick={() =>{
                                            sethpop(true)
                                            sethidpop(element.content)
                                            setcontentpop(element.content)
                                        }}
                                    >
                                        <path d="M16.77 8l1.94-2a1 1 0 0 0 0-1.41l-3.34-3.3a1 1 0 0 0-1.41 0L12 3.23zm-5.81-3.71L1 14.25V19h4.75l9.96-9.96-4.75-4.75z" />
                                    </svg>
                                    <p className="name">{element.partner}</p>
                                    <img
                                        className="avatar"
                                        src={
                                            "https://avatars.dicebear.com/api/open-peeps/" +
                                            element.partner +
                                            ".svg"
                                        }
                                        alt={"Logo de " + element.name}
                                    />
                                </div>
                                <p>{element.content}</p>
                            </div>
                        </div>
                    );
                })}
            </div>
        </div>
    );
}

function Y() {
    let { id } = useParams();
    return (
        <main>
            {/*FIXME - Use API instead : GET with the ID of useParams when done */}
            {id === Why.why.yid ? Hlist() : <Error code="501" />}
        </main>
    );
}

export default Y;
