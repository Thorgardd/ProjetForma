import { useState } from "react";
import "../../styles/header/Header.css";
function Header() {
    // TODO - react redux to disable on any action on a page
    const [shown, setshown] = useState(false);
    return (
        <header>
            <nav>
                <a href="/home">
                    <img
                        className="logo"
                        src="/assets/img/TYPdark.png"
                        alt="logo de TYP:Error"
                    ></img>
                </a>

                <svg
                    className="partner"
                    viewBox="4 4 16 16"
                    onClick={() => {
                        setshown(!shown);
                    }}
                >
                    <path
                        className="logo"
                        fill="currentColor"
                        d="M12,4A4,4 0 0,1 16,8A4,4 0 0,1 12,12A4,4 0 0,1 8,8A4,4 0 0,1 12,4M12,14C16.42,14 20,15.79 20,18V20H4V18C4,15.79 7.58,14 12,14Z"
                    />
                </svg>
            </nav>

            {shown && (
                <div className="account">
                    <div className="options">
                        <ul>
                            <li>
                                <span className="name">connection</span>
                            </li>

                            <li>
                                <span className="name">Inscription</span>
                            </li>
                        </ul>
                    </div>
                </div>
            )}
        </header>
    );
}

export default Header;
