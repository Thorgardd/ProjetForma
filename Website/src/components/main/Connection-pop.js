import "../../styles/main/Pop.css";
import { useEffect, useState } from "react";

function Connectionpop(props) {
    const [show, setShow] = useState(false);

    const closeHandler = (e) => {
        setShow(false);
        props.onClose(false);
    };

    useEffect(() => {
        setShow(props.show);
    }, [props.show]);

    return (
        <div className="ypop">
            <div>
                <h2>{props.title}</h2>
                <span onClick={closeHandler}>&times;</span>
                <div>coucou</div>
            </div>
        </div>
    );
}

export default Connectionpop;
