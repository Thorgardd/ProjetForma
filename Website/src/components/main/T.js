import { useParams } from "react-router";
import Whys from "../../mock/_t_123.json";
import Error from "./Error";
import "../../styles/main/T.css";
import { useState } from "react";
import Ypop from "./Y-pop"

function Ylist() {
    const [ypop, setypop] = useState(false);
    const popupCloseHandler = () => {
        setypop(false);
    };
    return (
        <div className="Tmap">

            {ypop && <Ypop onClose={popupCloseHandler} show={ypop}/>}

            <div className="list">
                {Whys.Whys.map((element, key) => {
                    return (
                        <a
                            href={"/Y/" + element.yid}
                            className="gallery"
                            key={key}
                            style={
                                element.status === "invalid"
                                    ? {
                                        borderColor: "var(--invalid)",
                                      }
                                    : element.status === "valid"
                                    ? {
                                          borderColor: "var(--valid)",
                                      }
                                    : {
                                          borderColor: "var(--pending)",
                                      }
                            }
                        >
                                <h2>{element.name}</h2>
                                <p>{element.description}</p>
                        </a>
                    );
                })}
            </div>

            <div className="prez">
                <div className="gallery neutral">
                    <img
                        className="fit-picture"
                        src={Whys.topic.image}
                        alt={"Logo de " + Whys.topic.name}
                    ></img>
                    <h1>{Whys.topic.name}</h1>
                    <p>{Whys.topic.description}</p>
                    <div className="add" onClick={() => setypop(true)}>+</div>
                </div>
            </div>
            
        </div>
    );
}

function T() {
    let { id } = useParams();
    return (
        <main>
            {/* FIXME - Use API instead : GET */}
            {id === Whys.topic.tid ? Ylist() : <Error code="501" />}
        </main>
    );
}

export default T;
