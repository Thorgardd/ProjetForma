import "../../styles/main/Pop.css";
import { useEffect, useState } from "react";

function Hpop(props) {
    const [show, setShow] = useState(false);
    const [hcontent, setcontent] = useState("");

    const closeHandler = (e) => {
        setShow(false);
        props.onClose(show);
    };

    const createhelp = (e) => {

        let h = {hcontent}
        if( hcontent === undefined ){
            h.hcontent = props.content;
        }

        if(typeof props.yid !== 'undefined'){
            // FIXME - Use API instead : PATCH
            console.log("Edit du help : "+ props.hid)
            console.log(h)
        }else{
            // FIXME - Use API instead : POST
            console.log(h)
        }

        closeHandler();
    };

    useEffect(() => {
        setShow(props.show);
    }, [props.show]);

    return (
        <div className="background">
            <div className="pop">
            <div className="cross" onClick={closeHandler}>&times;</div>

                <textarea
                    onChange={event => setcontent(event.target.value)}
                    placeholder="Expliquer ce qui ne vas pas." 
                    defaultValue={props.content}
                ></textarea>

                <div className="add" onClick={createhelp}>{typeof props.hid !== 'undefined'?"Modifier ma réponse":"Aider le partner"}</div>
            </div>
        </div>
    );
}

export default Hpop;
