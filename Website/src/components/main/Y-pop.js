import "../../styles/main/Pop.css";
import { useEffect, useState } from "react";

function Ypop(props) {
    const [show, setShow] = useState(false);
    const [yname, setyname] = useState(undefined);
    const [ydecription, setydecription] = useState(undefined);
    const [ycodesample, setycodesample] = useState(undefined);

    const closeHandler = (e) => {
        setShow(false);
        props.onClose(show);
    };

    const createwhy = (e) => {

        let y = {yname,ydecription,ycodesample}

        if( yname === undefined ){
            y.yname = props.name;
        }

        if( ydecription === undefined ){
            y.ydecription = props.description;
        }

        if( ycodesample === undefined ){
            y.ycodesample = props.codesample;
        }

        if(typeof props.yid !== 'undefined'){
            // FIXME - Use API instead : PATCH
            console.log("Edit du why : "+ props.yid)
            console.log(y)
        }else{
            // FIXME - Use API instead : POST
            console.log(y)
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

                <textarea className="title"
                    onChange={event => setyname(event.target.value)}
                    placeholder="Expliquer brievement le problème."
                    defaultValue= {props.name}
                ></textarea>

                <textarea
                    onChange={event => setydecription(event.target.value)}
                    placeholder="Donner plus de détails."
                    defaultValue= {props.description}
                ></textarea>

                <textarea
                    onChange={event => setycodesample(event.target.value)}
                    placeholder="Donner un petit bout de code." 
                    defaultValue= {props.codesample}
                ></textarea>

                <div className="add" onClick={createwhy}>Aider le partner</div>
            </div>
        </div>
    );
}

export default Ypop;
