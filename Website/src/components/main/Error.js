import Hero from "./partials/Hero.js";

function Readcode(code) {
    switch (code) {
        case "404":
            return <Hero context="404" />;
        case "501":
            return <Hero context="501" />;
        default:
            return "Not a standard error";
    }
}

function Error(props) {
    return <main>{Readcode(props.code)}</main>;
}

export default Error;
