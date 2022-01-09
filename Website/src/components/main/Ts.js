import Topics from "../../mock/_t.json";
import "../../styles/main/TS.css";

function Ts() {
    console.log(Topics);
    return (
        <div className="tsmap">
            {/*FIXME - Use API instead : GET*/}
                {Topics.map((element, key) => {
                    return (
                        <div className="topic">
                            <a key={key} href={"./T/" + element.tid}>
                                <img
                                    src={element.image}
                                    alt={"Logo de " + element.name}
                                />
                                <div className="name">{element.name}</div>
                            </a>
                        </div>
                    );
                })}
        </div>
    );
}

export default Ts;
